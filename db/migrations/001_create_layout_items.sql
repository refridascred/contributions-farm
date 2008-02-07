-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (state, level, weight) VALUES ('latest', 14, 49.22);
INSERT INTO layout_items (state, level, weight) VALUES ('standard', 94, 9.07);
INSERT INTO layout_items (state, level, weight) VALUES ('green', 40, 88.48);
