-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (count, score, label) VALUES (45, 60.53, 'legacy');
INSERT INTO layout_items (count, score, label) VALUES (83, 10.47, 'fallback');
INSERT INTO layout_items (count, score, label) VALUES (7, 22.72, 'fallback');
