-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (count, score, label, ratio) VALUES (27, 54.62, 'cached', 81.03);
INSERT INTO layout_items (count, score, label, ratio) VALUES (27, 32.95, 'standard', 89.44);
