-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    created_at TIMESTAMP,
    label TEXT,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (region, label, token, count) VALUES ('green', 'fallback', 'stable', 23);
INSERT INTO layout_items (region, label, token, count) VALUES ('fallback', 'staging', 'staging', 19);
INSERT INTO layout_items (region, label, token, count) VALUES ('standard', 'legacy', 'green', 63);
