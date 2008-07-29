-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    label TEXT,
    rank INTEGER,
    token TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (weight, label, rank, token, level) VALUES (27.65, 'fallback', 55, 'blue', 66);
INSERT INTO layout_items (weight, label, rank, token, level) VALUES (84.83, 'legacy', 35, 'edge', 36);
INSERT INTO layout_items (weight, label, rank, token, level) VALUES (80.79, 'legacy', 65, 'legacy', 54);
