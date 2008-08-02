-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    region TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (count, state, owner, region, rank) VALUES (10, 'eu-west', 'green', 'primary', 89);
INSERT INTO layout_items (count, state, owner, region, rank) VALUES (95, 'fallback', 'strict', 'stable', 93);
INSERT INTO layout_items (count, state, owner, region, rank) VALUES (94, 'blue', 'eu-west', 'legacy', 49);
