-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    region TEXT,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (state, rank, region, ratio, score) VALUES ('fallback', 78, 'primary', 87.2, 54.11);
INSERT INTO layout_items (state, rank, region, ratio, score) VALUES ('staging', 78, 'eu-west', 76.66, 80.25);
