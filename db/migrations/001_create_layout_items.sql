-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    level INTEGER,
    weight REAL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (state, label, level, weight, ratio) VALUES ('cached', 'edge', 6, 76.2, 90.73);
INSERT INTO layout_items (state, label, level, weight, ratio) VALUES ('local', 'stable', 20, 70.92, 92.87);
