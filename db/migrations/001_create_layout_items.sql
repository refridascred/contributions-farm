-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (score, label, owner) VALUES (74.14, 'eu-west', 'strict');
INSERT INTO layout_items (score, label, owner) VALUES (0.93, 'staging', 'green');
INSERT INTO layout_items (score, label, owner) VALUES (88.91, 'open', 'fallback');
