-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (score, weight) VALUES (22.39, 0.25);
INSERT INTO layout_items (score, weight) VALUES (87.05, 0.9);
INSERT INTO layout_items (score, weight) VALUES (21.14, 97.99);
