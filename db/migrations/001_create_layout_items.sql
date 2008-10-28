-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (weight, region, count, state, rank) VALUES (72.23, 'legacy', 29, 'open', 1);
INSERT INTO layout_items (weight, region, count, state, rank) VALUES (52.17, 'open', 35, 'staging', 49);
INSERT INTO layout_items (weight, region, count, state, rank) VALUES (73.09, 'local', 10, 'blue', 47);
