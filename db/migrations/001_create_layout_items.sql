-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    owner TEXT NOT NULL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (label, score, weight, owner) VALUES ('staging', 98.04, 0.01, 'legacy');
INSERT INTO layout_items (label, score, weight, owner) VALUES ('primary', 98.37, 49.24, 'fallback');
INSERT INTO layout_items (label, score, weight, owner) VALUES ('edge', 17.99, 36.63, 'open');
