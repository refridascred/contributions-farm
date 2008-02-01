-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (state, owner, rank, count, weight) VALUES ('blue', 'edge', 17, 30, 22.8);
INSERT INTO layout_items (state, owner, rank, count, weight) VALUES ('cached', 'open', 18, 89, 38.4);
INSERT INTO layout_items (state, owner, rank, count, weight) VALUES ('cached', 'standard', 14, 62, 66.73);
