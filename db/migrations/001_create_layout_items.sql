-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    ratio REAL,
    created_at TIMESTAMP,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (owner, ratio, label, active) VALUES ('primary', 50.18, 'primary', 60);
INSERT INTO layout_items (owner, ratio, label, active) VALUES ('blue', 30.01, 'edge', 4);
INSERT INTO layout_items (owner, ratio, label, active) VALUES ('local', 9.66, 'blue', 36);
