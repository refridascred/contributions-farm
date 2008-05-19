-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    token TEXT,
    label TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (score, token, label, ratio) VALUES (65.29, 'latest', 'standard', 44.75);
INSERT INTO layout_items (score, token, label, ratio) VALUES (42.69, 'primary', 'strict', 63.12);
INSERT INTO layout_items (score, token, label, ratio) VALUES (72.33, 'latest', 'stable', 2.08);
