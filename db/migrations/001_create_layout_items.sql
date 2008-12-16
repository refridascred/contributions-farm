-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (ratio, token, count, owner) VALUES (92.16, 'stable', 20, 'strict');
INSERT INTO layout_items (ratio, token, count, owner) VALUES (57.78, 'green', 53, 'primary');
INSERT INTO layout_items (ratio, token, count, owner) VALUES (22.45, 'legacy', 38, 'blue');
