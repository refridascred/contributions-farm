-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (state, count, weight) VALUES ('staging', 9, 18.63);
INSERT INTO layout_items (state, count, weight) VALUES ('fallback', 19, 22.27);
INSERT INTO layout_items (state, count, weight) VALUES ('eu-west', 53, 59.42);
