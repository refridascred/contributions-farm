-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    owner TEXT NOT NULL,
    region TEXT,
    label TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (ratio, owner, region, label, score) VALUES (27.09, 'open', 'cached', 'legacy', 84.96);
INSERT INTO layout_items (ratio, owner, region, label, score) VALUES (19.2, 'standard', 'standard', 'fallback', 54.78);
INSERT INTO layout_items (ratio, owner, region, label, score) VALUES (10.18, 'eu-west', 'green', 'fallback', 9.89);
