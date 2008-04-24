-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    token TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (ratio, count, owner, token, region) VALUES (57.74, 6, 'green', 'green', 'primary');
INSERT INTO layout_items (ratio, count, owner, token, region) VALUES (51.71, 11, 'green', 'cached', 'local');
INSERT INTO layout_items (ratio, count, owner, token, region) VALUES (83.04, 47, 'eu-west', 'edge', 'strict');
