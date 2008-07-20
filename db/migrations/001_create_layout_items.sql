-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (score, active, label) VALUES (15.51, 57, 'latest');
INSERT INTO layout_items (score, active, label) VALUES (93.56, 65, 'primary');
INSERT INTO layout_items (score, active, label) VALUES (79.98, 70, 'local');
