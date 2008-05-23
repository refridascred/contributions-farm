-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (score, rank, state) VALUES (46.73, 6, 'blue');
INSERT INTO layout_items (score, rank, state) VALUES (19.77, 89, 'edge');
INSERT INTO layout_items (score, rank, state) VALUES (98.08, 66, 'eu-west');
