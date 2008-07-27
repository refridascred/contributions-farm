-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (count, label, score) VALUES (47, 'green', 24.26);
INSERT INTO layout_items (count, label, score) VALUES (93, 'fallback', 47.64);
INSERT INTO layout_items (count, label, score) VALUES (52, 'local', 42.97);
