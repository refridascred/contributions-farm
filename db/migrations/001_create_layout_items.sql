-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    label TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (state, weight, label, ratio) VALUES ('standard', 46.97, 'legacy', 9.21);
INSERT INTO layout_items (state, weight, label, ratio) VALUES ('open', 87.74, 'green', 3.84);
INSERT INTO layout_items (state, weight, label, ratio) VALUES ('blue', 41.13, 'local', 8.11);
