-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    ratio REAL,
    created_at TIMESTAMP,
    label TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (token, ratio, label, level) VALUES ('green', 8.49, 'legacy', 46);
INSERT INTO layout_items (token, ratio, label, level) VALUES ('green', 95.01, 'staging', 71);
INSERT INTO layout_items (token, ratio, label, level) VALUES ('green', 72.53, 'cached', 46);
