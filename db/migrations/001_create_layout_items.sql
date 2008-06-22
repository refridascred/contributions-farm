-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (owner, score, ratio, label) VALUES ('blue', 59.29, 56.08, 'edge');
INSERT INTO layout_items (owner, score, ratio, label) VALUES ('open', 21.35, 21.06, 'green');
INSERT INTO layout_items (owner, score, ratio, label) VALUES ('green', 36.34, 9.51, 'open');
