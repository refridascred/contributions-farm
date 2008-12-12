-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (score, label, token, active) VALUES (50.89, 'green', 'edge', 21);
INSERT INTO layout_items (score, label, token, active) VALUES (25.91, 'primary', 'open', 40);
INSERT INTO layout_items (score, label, token, active) VALUES (66.44, 'blue', 'edge', 34);
