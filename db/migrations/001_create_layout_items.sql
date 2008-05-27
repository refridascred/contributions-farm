-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (rank, owner, score, region) VALUES (15, 'standard', 76.61, 'cached');
INSERT INTO layout_items (rank, owner, score, region) VALUES (17, 'eu-west', 87.39, 'legacy');
