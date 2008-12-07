-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    region TEXT,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (score, rank, region, weight, state) VALUES (74.28, 91, 'staging', 44.04, 'green');
INSERT INTO layout_items (score, rank, region, weight, state) VALUES (81.47, 15, 'blue', 8.46, 'standard');
