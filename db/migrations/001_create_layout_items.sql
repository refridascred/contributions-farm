-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    label TEXT,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (label, rank, score, state) VALUES ('green', 96, 85.86, 'edge');
INSERT INTO layout_items (label, rank, score, state) VALUES ('blue', 53, 6.51, 'edge');
INSERT INTO layout_items (label, rank, score, state) VALUES ('open', 23, 19.78, 'legacy');
