-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (ratio, active, token, level) VALUES (94.76, 59, 'latest', 30);
INSERT INTO layout_items (ratio, active, token, level) VALUES (8.51, 38, 'legacy', 21);
INSERT INTO layout_items (ratio, active, token, level) VALUES (39.88, 43, 'legacy', 16);
