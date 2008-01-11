-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    rank INTEGER,
    token TEXT,
    level INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (owner, rank, token, level, label) VALUES ('open', 16, 'open', 93, 'standard');
INSERT INTO layout_items (owner, rank, token, level, label) VALUES ('primary', 15, 'standard', 7, 'green');
INSERT INTO layout_items (owner, rank, token, level, label) VALUES ('edge', 12, 'strict', 67, 'standard');
