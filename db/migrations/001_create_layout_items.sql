-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (region, score, label) VALUES ('stable', 45.38, 'green');
INSERT INTO layout_items (region, score, label) VALUES ('open', 47.21, 'blue');
INSERT INTO layout_items (region, score, label) VALUES ('standard', 27.23, 'latest');
