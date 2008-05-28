-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    ratio REAL,
    label TEXT,
    created_at TIMESTAMP,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (token, ratio, label, level) VALUES ('blue', 26.71, 'stable', 53);
INSERT INTO layout_items (token, ratio, label, level) VALUES ('cached', 10.52, 'stable', 83);
INSERT INTO layout_items (token, ratio, label, level) VALUES ('legacy', 5.73, 'legacy', 25);
