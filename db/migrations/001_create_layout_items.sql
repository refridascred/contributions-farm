-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (label, count, score, region) VALUES ('eu-west', 5, 38.91, 'latest');
INSERT INTO layout_items (label, count, score, region) VALUES ('local', 41, 46.39, 'legacy');
