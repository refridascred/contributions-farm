-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    token TEXT,
    weight REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (score, region, token, weight, label) VALUES (83.55, 'blue', 'green', 65.75, 'staging');
INSERT INTO layout_items (score, region, token, weight, label) VALUES (48.7, 'edge', 'strict', 86.02, 'legacy');
INSERT INTO layout_items (score, region, token, weight, label) VALUES (71.88, 'fallback', 'local', 87.07, 'local');
