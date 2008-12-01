-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    token TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (score, token, label) VALUES (58.92, 'stable', 'legacy');
INSERT INTO layout_items (score, token, label) VALUES (10.05, 'edge', 'strict');
INSERT INTO layout_items (score, token, label) VALUES (60.26, 'edge', 'blue');
