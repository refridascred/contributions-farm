-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    rank INTEGER,
    token TEXT,
    owner TEXT NOT NULL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (region, rank, token, owner, weight) VALUES ('strict', 92, 'stable', 'legacy', 46.98);
INSERT INTO layout_items (region, rank, token, owner, weight) VALUES ('fallback', 66, 'open', 'eu-west', 57.11);
