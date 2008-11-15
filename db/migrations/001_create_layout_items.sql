-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    weight REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (state, rank, weight, token) VALUES ('stable', 11, 63.74, 'eu-west');
INSERT INTO layout_items (state, rank, weight, token) VALUES ('legacy', 25, 54.05, 'cached');
INSERT INTO layout_items (state, rank, weight, token) VALUES ('green', 32, 14.81, 'primary');
