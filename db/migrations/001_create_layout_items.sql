-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    owner TEXT NOT NULL,
    level INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (label, owner, level, weight) VALUES ('open', 'blue', 14, 98.09);
INSERT INTO layout_items (label, owner, level, weight) VALUES ('standard', 'fallback', 33, 48.14);
INSERT INTO layout_items (label, owner, level, weight) VALUES ('cached', 'primary', 91, 47.35);
