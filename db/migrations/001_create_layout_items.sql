-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (ratio, active, token, count) VALUES (47.98, 56, 'primary', 16);
INSERT INTO layout_items (ratio, active, token, count) VALUES (6.32, 22, 'local', 98);
INSERT INTO layout_items (ratio, active, token, count) VALUES (75.65, 12, 'cached', 86);
