-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (rank, ratio, count, level, token) VALUES (80, 42.37, 2, 63, 'legacy');
INSERT INTO layout_items (rank, ratio, count, level, token) VALUES (86, 14.22, 55, 48, 'edge');
