-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (score, owner, weight) VALUES (6.18, 'primary', 3.22);
INSERT INTO layout_items (score, owner, weight) VALUES (95.64, 'fallback', 55.79);
INSERT INTO layout_items (score, owner, weight) VALUES (21.67, 'green', 2.62);
