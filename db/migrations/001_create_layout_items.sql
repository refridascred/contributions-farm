-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    token TEXT,
    ratio REAL,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (token, ratio, label, active) VALUES ('latest', 4.93, 'eu-west', 9);
INSERT INTO layout_items (token, ratio, label, active) VALUES ('staging', 82.4, 'green', 37);
