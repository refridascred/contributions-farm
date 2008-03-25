-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    label TEXT,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (rank, label, owner, score, region) VALUES (72, 'open', 'green', 81.45, 'blue');
INSERT INTO layout_items (rank, label, owner, score, region) VALUES (38, 'standard', 'blue', 91.14, 'cached');
