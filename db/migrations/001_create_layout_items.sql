-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (weight, score, state, region) VALUES (36.38, 5.82, 'eu-west', 'staging');
INSERT INTO layout_items (weight, score, state, region) VALUES (25.69, 53.95, 'strict', 'strict');
