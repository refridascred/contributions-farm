-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    rank INTEGER,
    region TEXT,
    owner TEXT NOT NULL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (level, rank, region, owner, token) VALUES (39, 5, 'fallback', 'latest', 'strict');
INSERT INTO layout_items (level, rank, region, owner, token) VALUES (13, 39, 'staging', 'fallback', 'local');
INSERT INTO layout_items (level, rank, region, owner, token) VALUES (74, 57, 'latest', 'staging', 'edge');
