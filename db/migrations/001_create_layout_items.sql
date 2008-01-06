-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (weight, state, ratio, rank) VALUES (62.76, 'blue', 58.29, 50);
INSERT INTO layout_items (weight, state, ratio, rank) VALUES (72.49, 'primary', 30.95, 59);
INSERT INTO layout_items (weight, state, ratio, rank) VALUES (72.5, 'legacy', 96.35, 52);
