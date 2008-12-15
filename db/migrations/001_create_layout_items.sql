-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    ratio REAL,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (token, ratio, weight, active, label) VALUES ('stable', 72.77, 79.79, 84, 'fallback');
INSERT INTO layout_items (token, ratio, weight, active, label) VALUES ('fallback', 35.96, 97.29, 93, 'strict');
