-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (weight, score, state) VALUES (67.54, 4.32, 'latest');
INSERT INTO layout_items (weight, score, state) VALUES (68.8, 32.56, 'primary');
INSERT INTO layout_items (weight, score, state) VALUES (28.97, 3.75, 'staging');
