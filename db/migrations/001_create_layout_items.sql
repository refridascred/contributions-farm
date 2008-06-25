-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    label TEXT,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (state, weight, label, region, count) VALUES ('blue', 28.78, 'stable', 'green', 61);
INSERT INTO layout_items (state, weight, label, region, count) VALUES ('blue', 62.07, 'green', 'cached', 93);
INSERT INTO layout_items (state, weight, label, region, count) VALUES ('open', 27.25, 'latest', 'eu-west', 64);
