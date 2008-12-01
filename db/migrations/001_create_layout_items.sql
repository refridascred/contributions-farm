-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (label, state, weight, count) VALUES ('green', 'open', 4.01, 78);
INSERT INTO layout_items (label, state, weight, count) VALUES ('blue', 'strict', 30.8, 7);
INSERT INTO layout_items (label, state, weight, count) VALUES ('strict', 'latest', 31.08, 88);
