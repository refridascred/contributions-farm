-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    level INTEGER,
    region TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (score, label, level, region, rank) VALUES (80.52, 'stable', 54, 'staging', 95);
INSERT INTO layout_items (score, label, level, region, rank) VALUES (5.2, 'staging', 0, 'latest', 17);
INSERT INTO layout_items (score, label, level, region, rank) VALUES (7.26, 'open', 71, 'standard', 24);
