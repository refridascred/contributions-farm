-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    label TEXT,
    weight REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (token, label, weight, score) VALUES ('staging', 'blue', 50.37, 98.57);
INSERT INTO layout_items (token, label, weight, score) VALUES ('cached', 'standard', 6.03, 9.26);
INSERT INTO layout_items (token, label, weight, score) VALUES ('cached', 'strict', 35.53, 46.18);
