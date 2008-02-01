-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    token TEXT,
    weight REAL,
    label TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (token, weight, label, score) VALUES ('standard', 43.15, 'staging', 0.47);
INSERT INTO layout_items (token, weight, label, score) VALUES ('primary', 66.57, 'standard', 72.36);
INSERT INTO layout_items (token, weight, label, score) VALUES ('legacy', 56.61, 'latest', 80.48);
