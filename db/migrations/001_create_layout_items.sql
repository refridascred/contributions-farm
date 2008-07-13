-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (rank, region, score, owner, token) VALUES (49, 'local', 23.45, 'cached', 'staging');
INSERT INTO layout_items (rank, region, score, owner, token) VALUES (63, 'staging', 53.03, 'legacy', 'standard');
