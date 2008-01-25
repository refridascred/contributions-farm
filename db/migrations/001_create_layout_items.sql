-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    region TEXT,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (label, region, level, score) VALUES ('open', 'standard', 13, 67.04);
INSERT INTO layout_items (label, region, level, score) VALUES ('cached', 'stable', 84, 36.4);
