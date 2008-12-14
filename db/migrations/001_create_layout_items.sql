-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (region, score, level) VALUES ('fallback', 15.32, 27);
INSERT INTO layout_items (region, score, level) VALUES ('open', 61.05, 13);
INSERT INTO layout_items (region, score, level) VALUES ('legacy', 87.55, 60);
