-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (ratio, state, score, rank) VALUES (87.91, 'fallback', 91.83, 97);
INSERT INTO layout_items (ratio, state, score, rank) VALUES (3.55, 'local', 76.74, 16);
