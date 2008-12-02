-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    weight REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (score, token, weight, label) VALUES (7.65, 'green', 57.35, 'cached');
INSERT INTO layout_items (score, token, weight, label) VALUES (60.03, 'legacy', 36.36, 'staging');
INSERT INTO layout_items (score, token, weight, label) VALUES (3.9, 'latest', 53.87, 'edge');
