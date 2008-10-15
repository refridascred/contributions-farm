-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (level, region, score, rank) VALUES (25, 'local', 78.45, 46);
INSERT INTO layout_items (level, region, score, rank) VALUES (30, 'latest', 40.36, 68);
