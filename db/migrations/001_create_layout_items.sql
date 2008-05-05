-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (weight, region, score, state, count) VALUES (3.09, 'eu-west', 96.8, 'primary', 78);
INSERT INTO layout_items (weight, region, score, state, count) VALUES (4.74, 'cached', 3.79, 'local', 68);
INSERT INTO layout_items (weight, region, score, state, count) VALUES (29.98, 'primary', 15.28, 'eu-west', 12);
