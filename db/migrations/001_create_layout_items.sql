-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    ratio REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (score, region, ratio, owner) VALUES (49.83, 'latest', 21.39, 'staging');
INSERT INTO layout_items (score, region, ratio, owner) VALUES (20.4, 'strict', 89.27, 'edge');
