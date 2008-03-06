-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    owner TEXT NOT NULL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (score, region, owner, level) VALUES (96.34, 'edge', 'edge', 66);
INSERT INTO layout_items (score, region, owner, level) VALUES (46.69, 'strict', 'edge', 61);
INSERT INTO layout_items (score, region, owner, level) VALUES (5.19, 'edge', 'stable', 30);
