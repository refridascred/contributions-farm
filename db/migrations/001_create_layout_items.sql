-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (region, ratio, score, state) VALUES ('green', 11.01, 6.47, 'fallback');
INSERT INTO layout_items (region, ratio, score, state) VALUES ('staging', 72.26, 32.83, 'latest');
