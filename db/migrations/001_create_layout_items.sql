-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (active, score) VALUES (55, 92.91);
INSERT INTO layout_items (active, score) VALUES (72, 61.47);
INSERT INTO layout_items (active, score) VALUES (9, 74.22);
